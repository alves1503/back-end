<?php

include_once("templates/header.php");

if (isset($_GET['id'])) {
  $postId = $_GET['id'];
  $currentPost;

  foreach ($posts as $post) {
    if ($post['id'] == $postId) {
      $currentPost = $post;
    }
  }
}

?>



<main id="post-container">

  <div class="content-container">
    <h1 id="main-title"><?= $currentPost['title'] ?></h1>
    <p id="post-descripton"><?= $currentPost['description'] ?></p>
    <div class="img-container">
      <img src="<?= $BASE_URL ?>/img/<?= $currentPost['img'] ?>" alt="<?= $currentPost['title'] ?>">
    </div>
    <p class="post-cotent">Lorem ipsum dolor sit amet consectetur adipisicing elit. Quidem, facere nesciunt quas sint provident sapiente expedita a officiis eum fugiat unde illo blanditiis voluptatibus doloribus culpa nobis, necessitatibus quibusdam! Quibusdam.
      Unde, possimus neque voluptates vitae eos ipsam iusto aliquam optio a illum dicta iure excepturi dolor facilis nisi eius natus, provident non sit quo totam. Quas totam incidunt omnis non.
      Dicta qui esse quo incidunt! Expedita sequi corrupti, quidem quas est tempora voluptatum illo earum iure, natus doloremque atque nihil. Aspernatur doloribus non, asperiores tempore minus molestiae ut assumenda exercitationem!
      Doloribus reprehenderit repellat aut nisi quos, eveniet aperiam, saepe optio omnis impedit aspernatur ea consequuntur deserunt natus laudantium sequi excepturi ab eius! Assumenda nostrum excepturi illo at quia, officiis eos.
      Placeat reiciendis repellat excepturi, eveniet esse cupiditate omnis molestiae. Quaerat eius debitis illo totam obcaecati quos nisi, molestias quas repellendus doloribus omnis, possimus repudiandae nulla ullam at, ex quo placeat!</p>
    <p class="post-cotent">Lorem ipsum dolor sit amet consectetur adipisicing elit. Quidem, facere nesciunt quas sint provident sapiente expedita a officiis eum fugiat unde illo blanditiis voluptatibus doloribus culpa nobis, necessitatibus quibusdam! Quibusdam.
      Unde, possimus neque voluptates vitae eos ipsam iusto aliquam optio a illum dicta iure excepturi dolor facilis nisi eius natus, provident non sit quo totam. Quas totam incidunt omnis non.
      Dicta qui esse quo incidunt! Expedita sequi corrupti, quidem quas est tempora voluptatum illo earum iure, natus doloremque atque nihil. Aspernatur doloribus non, asperiores tempore minus molestiae ut assumenda exercitationem!
      Doloribus reprehenderit repellat aut nisi quos, eveniet aperiam, saepe optio omnis impedit aspernatur ea consequuntur deserunt natus laudantium sequi excepturi ab eius! Assumenda nostrum excepturi illo at quia, officiis eos.
      Placeat reiciendis repellat excepturi, eveniet esse cupiditate omnis molestiae. Quaerat eius debitis illo totam obcaecati quos nisi, molestias quas repellendus doloribus omnis, possimus repudiandae nulla ullam at, ex quo placeat!</p>
  </div>

  <aside id="nav-container">
    <h3 id="tags-title">Tags</h3>
    <ul id="tags-list">
      <?php foreach ($currentPost['tags'] as $tag): ?>
        <li><a href="#"><?= $tag ?></a></li>
      <?php endforeach ?>
    </ul>
    <h3 id="categories-title">Categorias</h3>
    <ul id="categories-list">
      <?php foreach ($categories as $categoria): ?>
        <li><a href="#"><?= $categoria ?></a></li>
      <?php endforeach ?>
    </ul>
  </aside>

</main>




<?php
include_once("templates/footer.php");
?>